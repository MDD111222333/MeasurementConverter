# C_Sharp_Generics_MeasurementConverter

## C#_Generics_MeasurementConverter

### Задание «Контрольная точка №28 — обобщённые методы, структуры и делегаты»[cite: 15]

Вариант 1. Измерение с единицами[cite: 15]
1. struct Measurement<T> { T Value; string Unit; } с переопределённым ToString().[cite: 15]
2. delegate TResult Converter<T, TResult>(T value);[cite: 15]
3. Обобщённый метод Measurement<TResult> Convert<T, TResult>(Measurement<T> source, Converter<T, TResult> converter, string newUnit).[cite: 15]
4. Создайте Measurement<double> (например, температура в градусах Цельсия) и преобразуйте её в Measurement<double> в других единицах (Фаренгейт) через лямбду.[cite: 15]
5. Тем же методом преобразуйте другое Measurement<T> в результат ДРУГОГО типа (например, Measurement<double> температуры в Measurement<string> текстовой категории — «холодно»/«тепло»), доказав, что метод работает для разных пар типов.[cite: 15]

Результаты и проверочные ключи:

<img width="1794" height="285" alt="изображение" src="https://github.com/user-attachments/assets/51ef8e5f-a030-41ab-a463-ce8c83402aee" />

Результат работы:
<img width="1752" height="486" alt="изображение" src="https://github.com/user-attachments/assets/ccaad1a5-49db-46c7-aa3c-36b5d9fef747" />
