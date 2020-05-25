library("neuralnet")
output <- as.data.frame(runif(100, min = 1, max = 10))
input <- log(output^2)
trainingData <- cbind(output,input)
colnames(trainingData) <- c("Input", "Output")
normalize <- function(x) {
  return ((x - min(x)) / (max(x) - min(x)))
}
maxmindf <- as.data.frame(lapply(trainingData, normalize))
net.price <- neuralnet(Output~Input, maxmindf, hidden = c(4, 5, 3), threshold = 0.01)
plot(net.price)

new.speeds <- data.frame(
  speed = c(12, 19, 24)
)

plot(new.speeds)

predict(net.price, newdata = new.speeds, interval = "confidence")
predict(net.price, newdata = new.speeds, interval = "prediction")

out <- as.data.frame(runif(100, min = 1, max = 20))
int <- log(output^2)
training <- cbind(out,int)
colnames(training) <- c("Int", "Out")
normalize <- function(x) {
  return ((x - min(x)) / (max(x) - min(x)))
}
maxmindf <- as.data.frame(lapply(training, normalize))
net.price_2 <- neuralnet(Out~Int, maxmindf, hidden = c(4, 5, 3), threshold = 0.01)
plot(net.price_2)

predict(net.price, newdata = out, interval = "confidence")


