from flask import Flask # Мы импортируем flask


app = Flask(__name__) #Создаем экземпляр этого класса(создаем приложение), name - Удобный ярлык

@app.route("/") # Декоратор -чтоб ссообщить Flask какой urll адрес должен запускать нашуфункцию
def main(): # Чтобы в PYTHON создать функцию необходимо писать def
  return "<h1>Hello, world!</h1>"


@app.route("/info") # При переходе /info
def info():
  return "<h1>Меня создала компания GeekBrains!</h1>"


if __name__ == "__main__":
  app.run()