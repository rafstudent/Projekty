Shader "Custom/New_Water"
{
	Properties
	{
		_Kolor("Kolor", Color) = (1, 1, 1, 1)
		_Krawedzie("Kolor krawędzi", Color) = (1, 1, 1, 1)
		_Glebia("Głębia", 2D) = "white" {}
		_Ad_Tex("Dodatkowa tekstura", 2D) = "white" {}
		_MainTex("Główna tekstura", 2D) = "white" {}
	}

		SubShader
		{
			GrabPass
			{
			}
			Pass
			{

				CGPROGRAM
				#pragma vertex vert
				#pragma fragment frag
				#include "UnityCG.cginc"

				sampler2D _BTexture;
				sampler2D _Ad_Tex;

				struct vertexInput
				{
					float4 vertex : POSITION;
					float3 normal : NORMAL;
					float3 texCoord : TEXCOORD0;
				};

				struct vertexOutput
				{
					float4 pos : SV_POSITION;
					float4 grabPos : TEXCOORD0;
				};

				vertexOutput vert(vertexInput input)
				{
					vertexOutput output;

					output.pos = UnityObjectToClipPos(input.vertex);
					float4 normal4 = float4(input.normal, 0.0);
					float3 normal = normalize(mul(normal4, unity_WorldToObject).xyz);

					output.grabPos = ComputeGrabScreenPos(output.pos);

					float dodatkowa = tex2Dlod(_Ad_Tex, float4(input.texCoord.xy, 0, 0));

					return output;
				}

				float4 frag(vertexOutput input) : COLOR
				{
					return tex2Dproj(_BTexture, input.grabPos);
				}
				ENDCG
			}

			Pass
			{
				Blend SrcAlpha OneMinusSrcAlpha

				CGPROGRAM
				#include "UnityCG.cginc"

				#pragma vertex vert
				#pragma fragment frag

					float4 _Kolor;
					float4 _Krawedzie;
					sampler2D _CameraDepthTexture;
					sampler2D _Glebia;
					sampler2D _Ad_Tex;
					sampler2D _MainTex;

					struct vertexInput
					{
						float4 vertex : POSITION;
						float4 texCoord : TEXCOORD1;
					};

					struct vertexOutput
					{
						float4 pos : SV_POSITION;
						float4 texCoord : TEXCOORD0;
						float4 screenPos : TEXCOORD1;
					};

					vertexOutput vert(vertexInput input)
					{
						vertexOutput output;

						output.pos = UnityObjectToClipPos(input.vertex);

						float dodatkowa = tex2Dlod(_Ad_Tex, float4(input.texCoord.xy, 0, 0));

						output.screenPos = ComputeScreenPos(output.pos);
 
						output.texCoord = input.texCoord;

						return output;
					}

					float4 frag(vertexOutput input) : COLOR
					{
						float4 Glebia_s = SAMPLE_DEPTH_TEXTURE_PROJ(_CameraDepthTexture, input.screenPos);
						float glebia = LinearEyeDepth(Glebia_s).r;

						float foamLine = 1 - saturate((glebia - input.screenPos.w));
						float4 foamRamp = float4(tex2D(_Glebia, float2(foamLine, 0.5)).rgb, 1.0);

						float4 albedo = tex2D(_MainTex, input.texCoord.xy);

						float4 col = _Kolor * foamRamp * albedo;
						return col;
					}

					ENDCG
				}
		}
}