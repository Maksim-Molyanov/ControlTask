# ControlTask

### Основная программа 
 * Ввод размера массива и присвоение в переменную "size".

 * Создание массива **array** и присвоение к ниму результата функции **CreateArr(size)**.

 * Вывод массива **array** через функцию **PrintArray**.

* Создание массива **result** и присвоение к ниму результата функции **FilterArr(array)**. 

* Вывод массива **result** через функцию **PrintArray**.

## В программе три функция:
1. **CreateArr** - принимает размер массива "size". 
    * Создает массив строк, размера "size".
    * Ввод элементов массива.
    * Возвращает массив строк.

2. **FilterArr** - принимает массив строк "array".
    * Создает новый массив размера "array.Length".
    * Создает переменную "j", для заполнения нового массива по индексу.
    * В цикле отбирает элементы массива размера меньше или равно 3.
    * Изменяет размер нового массива, через "Array.Resize".
    * Возвращает новый массив.

3.  **PrintArray** - принимает массив строк "array".
    * Вывод массива через цикл.

