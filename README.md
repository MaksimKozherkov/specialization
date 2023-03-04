# Условия задачи

Написать программу, которая из имеющегося массива строк формирует массив из строк длина которых
меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте
выполнения алгоритма. При решении, не рекомендуется пользоваться коллекциями, лучше обойтись
исключительно массивами.

### Примеры:

    1) ["Hello", "2", "world", ":-)"] -> ["2", ":-)"]
    2) ["1234", "1567", "-2", "computer science"] -> ["-2"]
    3) ["Russia", "Denmark", "Kazan"] -> [ ]

# Описание решения

### Алгоритм:
1. Пользователь задает размер массива **(size)**.
2. Пользователь задает длину элемента, которые нужно отобразить в новом массиве **(WordLength)**.
3. Используем метод **GetArray**, где пользователь вводит элементы исходного массива. С помощью цикла все элементы вводимые пользователем, присваиваем по индексам в массив и таким образом формируем исходный массив.
4. Выводим на экран, для наглядности.
5. Формируем новый массив с помощью метода **NewArray**, для выполнения условий поставленной задачи.
6. Первым делом, производим расчет размера нового массива, с помощью цикла, где задаем счетчик **(Count)**, в теле цикла прописываем условие, где программа должна выбрать те слова, длина которого, не должна превышать значения **(WordLength)**, который задал пользователь. Как только цикл находит удовлетворяющие по условию элементы, счетчик **(Count)** прибавляется на 1. Цикл пройдя весь исходный массив, посчитает количество элементов и тем самым, мы узнаем размер нового массива из элементов удовлетворяющему условию поставленной задачи.
7. После того, как определили размер нового массива, который показывает наш счетчик **(Count)**. Создаем новый массив с помощью цикла. Циклом перебираем исходный массив с элементами и те элементы, которые удовлетворяют условию поставленной задачи, записываем их в новый массив.
8. Выводим на экран, полученный новый массив из тех элементов, которые удовлетворяют условию поставленной задачи.