# Итоговая проверочная работа

## *Задача*
Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна трём символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

## *Алгоритм решения*
1. Создаём исходный массив:
    1. Выводим запрос пользователю на ввод количества элементов маcсива `firstArrayLength`.
    2. Вызываем метод `CreateStringArray`, создающий массив заданным размером. Данный метод заполняет массив путём ввода каждого элемента пользователем с клавиатуры.
2. Чтобы отобразить созданный в п. 1 массив, вызываем метод `PrintArray`.
3. Задаём значение максимально допустимого количества символов в элементе `maxElemLength`.

    >*по условию максимально допустимого количества символов в элементе - 3*

4. Создаём новый массив:
    1. Вызываем метод `GetNewArrayLength`, возвращающий количество элементов созданного в п. 1 массива, которые не превышают максимально допустимого количества символов согласно п. 3.
    2. Вызываем метод `GetNewArray`, возвращающий новый массив, используя исходный массив, созданный в п. 1, с количеством элементов, определенных п. 4.1 и не превышающих максимально допустимого количества символов согласно п. 3. 
5. Чтобы отобразить созданный в п. 4 массив, вызываем метод `PrintArray`.

## *Результат*
["hello", "2", "world", ":-)"] -> ["2", ":-)"] <br> ["1234", "1567", "-2", "computer science"] -> ["-2"] <br> ["Russia", "Denmark", "Kazan"] -> []