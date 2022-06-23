# coursework_schonhage-strassen-algorithm
The project conducted a thorough study of the Schonhage-Strasen algorithm, described all the terms related to this algorithm and the process of its work, as well as all stages of its implementation in C# using development environment Visual Studio 2019.

## Цей програмний продукт є *результатом* курсової роботи.
Основним завданням даної курсової роботи є розробка додатку для множення простих великих чисел. Інтерфейс користувача має бути простим та складатися з декількох текстових та кнопки, при натисканні якої вхідні числа мають перемножитись, використовуючи ***алгоритм Шенхаге-Страсена***. Також бажано добавити поле, яка покаже скільки часу програма витратила на множення. Проте потрібно пам’ятати, що ці результати сильно залежать від конкретного апаратного забезпечення. Паралельно з цим має йти підрахунок кількості символів у полях, де користувач вводить вхідні дані.
Програмне забезпечення має бути надійним, тобто при введені користувачем неправильних даних, програма по-перше, має повідомити про це користувача, по-друге, мати змогу продовжити коректне функціонування

## Посилання на курсову роботу: https://drive.google.com/file/d/1DTYfJJ8BUbdeOUwzQv-2UmTt-zaVD-To/view?usp=sharing

## Поверхневий опис алгоритму
<p align="center">
  Створення контейнерів a i b
  <img src="https://user-images.githubusercontent.com/89083538/175357993-2e05be9d-93d8-463c-914c-16c68d52a262.png" alt="contA and contB"/>
  Виконання ациклічної згортки
  <img src="https://user-images.githubusercontent.com/89083538/175358140-434b78d8-e974-46da-b630-b38f8b301bea.png" alt="FindAcyclicConvolution"/>
  Множення на відповідний ступінь 10
  <img src="https://user-images.githubusercontent.com/89083538/175358504-87bf3b75-04e8-4338-bc24-f7c8afcbf2b4.png" alt="PerformCarry"/>
</p>

## Screenshots
<p align="center">
  <img src="https://user-images.githubusercontent.com/89083538/175359762-b5bd9c71-9a84-4fd1-8d9a-0aeccf994d4e.png" alt="mainForm"/>
  ***
  <img src="https://user-images.githubusercontent.com/89083538/175359898-74a984fc-b611-4c69-aaed-3eb1fb8dd3d4.png" alt="FindAcyclicConvolution"/>
  ***
  <img src="https://user-images.githubusercontent.com/89083538/175359982-109c4382-8f99-4786-92e0-1c6a21a4b30c.png" alt="time"/>
</p>
