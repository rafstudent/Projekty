library("neuralnet")

setwd("C:/Users/Hp/Desktop/Studia magisterka/Uczenie maszynowe/Zadanie_3B")
smartfony <- read.csv("smartfony.csv")

cena_1 <- normalize(smartfony$cena)
cena_1

smartfony <- smartfony[,-5]
smartfony <- smartfony[,-1]
smartfony

pamie_RAM_1 <- normalize(smartfony$pamie_RAM)
pamie_RAM_1
aparat_foto_1 <- normalize(smartfony$aparat_foto)
aparat_foto_1
liczba_opinii_1 <- normalize(smartfony$liczba_opinii)
liczba_opinii_1

smartfony <- cbind(smartfony, cena_1, pamie_RAM_1, aparat_foto_1, liczba_opinii_1)
smartfony

net.price <- neuralnet(cena_1~pamie_RAM_1+aparat_foto_1+ocena_klientow+liczba_opinii_1,
                       smartfony, hidden = c(4,5,3), threshold = 0.01)

plot(net.price)
