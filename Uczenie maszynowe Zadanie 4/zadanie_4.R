library("C50") 
setwd("C:/Users/Hp/Desktop/Zadanie4")
dane <- read.csv('smartfony.csv') 

dane$ocena_klientow <- factor(dane$ocena_klientow) 
head(dane) 
treeModel <- C5.0(x=dane[,-6], y=dane$ocena_klientow)

treeModel 
summary(treeModel) 
plot(treeModel) 