library("mlr")
library("DiscriMiner")
library("rFerns")
library("randomForestSRC")

normalize <- function(x) {
  return ((x - min(x)) / (max(x) - min(x)))
}


setwd("C:/Users/Hp/Desktop/Studia magisterka/Uczenie maszynowe/Zadanie 5.2")
data <- read.csv("smartfony.csv")
data$ocena_klientow<-factor(data$ocena_klientow)
data$pamie_RAM<-normalize(data$pamie_RAM)
data$pamie_wbudowana<-normalize(data$pamie_wbudowana)
data<-data.frame(data)
zadanie = makeClassifTask(id = 'smartfony', 
                          data, 
                          "ocena_klientow",
                          weights = NULL, 
                          blocking = NULL, 
                          coordinates = NULL,
                          positive = NA_character_, 
                          fixup.data = "warn", 
                          check.data = TRUE)
ponowne_probkowanie = makeResampleDesc("Bootstrap", iters = 3)
metody_uczenia <- makeLearners(c("rpart", "C50","rFerns","randomForestSRC"), type = "classif")
porownanie_metod_uczenia <- benchmark(learners = metody_uczenia,
                                      tasks = zadanie,
                                      resampling = ponowne_probkowanie)