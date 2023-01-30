Задача :
Написать программу, которая из имеющегося массива строк формирует массив из строк, 
длина которых меньше либо равна 3 символа. 
Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
При решение не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами
Примеры:
[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
[“1234”, “1567”, “-2”, “computer science”] → [“-2”]
[“Russia”, “Denmark”, “Kazan”] → []

Описание алгоритма:
Объявляю массив изначальный размером 5 ячеек тип - строчный, заполняю данными вручную.
Объявляю массив итоговый, размером равным длине (количеству ячеек) изначального массива, тип - строчный.
Объявляю метод формирования итогового массива, в котором идет последовательный перебор элементов и выполнение условия сравнения длины элемента с 3.
Если длина элемента меньше 3, то текущий элемент записывается в ячейку итогового массива.
Объявляю метод вывода масиива.
Обращаюсь к методу формирования итогового массива с конкретными аргументами.
Обращаюсь к методам вывода массива два раза (исходный и итоговый), с выводом комментариев, где какой.

Блок-схема расположена в папке BlockDiagram в формате pdf и редактируемом .drawio.
Код программы в файле Program.cs.