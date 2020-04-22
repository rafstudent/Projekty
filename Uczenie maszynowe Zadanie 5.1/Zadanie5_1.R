library("C50") 
library("MASS") 
data("OME") 
head(OME)
treeModel <- C5.0(x=OME[,-3], y=OME$OME)
treeModel
summary(treeModel) 
plot(treeModel) 