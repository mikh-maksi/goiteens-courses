# Селекторы
1. Сделайте 5 абзацев, каждый из которых заполнен по три раза повторяющихся текста "Lorem ipsum dolor sit amet consectetur adipisicing elit. Labore, deleniti. Ullam numquam quis fuga, vitae, veniam ratione deserunt quos pariatur, cum sed blanditiis architecto deleniti sapiente. Repudiandae quae molestiae magnam." Для всех абзацев сделайте размер шрифта 14px (font-size:14px;), цветом текста #111111; с небольшой светло-серой пунктирной рамкой, фоном; отступ между абзацами должен быть равен 30px;
2. На основе задания в пункте 1. Сделайте "красную строку" (свойство text-indent:20px;)
3. Создайте универсальный блочный контейнер (div) размером 200px на 200px, задайте ему бледно-синий фон; с помощью внутреннего отступа (padding) сделайте так, чтобы текст начинался не от левого края, а отступал от левого края 200 px.
4. Задайте список из 3-х элементов (например, названия линий метро). Сделайте так, чтобы каждый пункт списка был написан своим текстом (например красным, зеленым и синим).
# Наследование
1. Создайте блок-обертку (универсальный блочный контейнер с классом wrapper). Напишите 3 абзаца с заполнителем-рыбой (lorem ipsum...) внутри тега-обертки и три абзаца вне этого блока. Для абзацев внутри тега-обертки задайте красную строку и размер шрифта 18 (.wrapper p{text-indent:20px; font-size:19px;}), для всех остальных абзацев - установите размер шрифта 16px.
2. Для задания из п.1. задайте одрному из абзацев идентификатор (id='p1') и для этого идентификатора задайте подчеркивание, написание всеми большими буквами и красный цвет (#p1{text-decoration:underline; text-transform:uppercase; color:red})
3. Сделайте текст из 6 абзацев, для каждого задайте классы p1,p2,p3,p4,p5,p6 соответственно. Для каждого абзаца задайте свой цвет написания. Для одного из абзацев (выберите сами) задайте фон, сделайте это через оборачивание соответствующего абзаца универсальным блочным контейнером с классом (например с классом wrapper_p). И обращение к соответствующему абзацу через каскад (например .wrapper_p p{}).
# Строчные, строчно-блочные и блочные элементы.
1. Сделайте три абзаца с заполнителем-рыбой. Установите для них тип отображения "строчный элемент" (p{display:inine;}). Опишите в комментариях к работе как изменилось отображение абзацев.
2. Сделайте два универсальных блочных контейнера с разным цветом фона (например серым и синим). Установите им тип отображения "строчно-блочный элемент" (display:inline-block;), а также - размер 48%. Опишите в комментариях как изменилось отображения контейнеров.
3. Создайте 5 универсальных контейнера (div) сверстайте их так, как показано на рисунке: <img src = "http://fecore.net.ua/images/module-3/html-layout-example.png">
# Особенности margin
1. Создать 3 блока (блочный, строчно-блочный, строчный). Каждому из этих блоков задать внешний отступ сверху (margin-top) 20 px. А также внешний отступ слева (margin-left) 30 пикселей. Какие из отступов сработали, какие нет?
2. Создать 2 блочных блока. У первого (верхнего) отступ снизу (margin-bottom) 60 пикселей. У нижнего отступ сверху (margin-top) 40 пикселей. Какой отступ будет между блоками?
3. Создайте 2 блочных конейнера. Один внутри другого (тот что внутри - называется дочерним; тот контейнер внутри которого находится другой называется родительским). а. У дочернего контейнера задайте внешний верхний отступ размером в 30 пикселей. Какое расстояние будет между верхними гранями этих блоков? Какой отступ будет между родительским блоком и тем, который находится над ним.
# Выравнивание контента
1. Создайте блочный контейнер. Напишите в нем текст с 2 строчными парными тегами. Выровняйте тег по центре относительного родительского блока.
2. Создайте блочный контейнер. Выровняйте его по центру относительного его родительского элемента. Подсказка (у блочного контейнера должна быть задана ширина, выравниваете производится с помощью свойства, которое задает внешний отступ: margin).
3. Задайте внутри блочного контейнера строчно-блочный. Выровняйте строчно-блочный контейнер по верхнему краю.
4. Напишите формулу: "Квадрат гипотенузы равен сумме квадратов катетов".
# Оформление текста
1. Задайте заголовок: размером шрифта 36 пикселей, синего цвета.
2. Задайте буквицу (псевдокласс:: first-letter)/ используйте фигурный шрифт из семейств google.fonts, "красную строку" (отступ первой строки в абзаце) сделайте размером 15 пикселей.
3. Создайте шрифт (рыбу) с межстрочным интервалом в 1,5 раза больше высоты текста. Высоту текста задайте размером 20 пикселей.
# Фон
1. Подберите фон, чтобы на нем читался: а. белый текст; б. Черный текст; в. Желтый текст; г. Синий текст.
2. Задайте два блочных элемента один в другом. Задайте родительскому элементу синий фон, а дочернему - желтый.
3. Задайте фон для сайта (для тега body), чтобы он занимал весь экран даже, если конента на экране будет меньше.
4. Какой сайт будет работать быстрее: тот у которого полупрозрачный или тот у которого прозрачный фон.
5. Задайте универсальный блочный контейнер, выровнянный по центру, с фоном в виде смайлика (картинку смайлика можно найти и скачать в google.com или на сайте изображений iconfinder.com)
6. "Замостите" всю страницу браузера смайликами. а. Полностью весь экран. б. По горизонтали. в. По вертикали.
7. Создайте блок, который в два раза меньше чем его фон. Установите фон, так чтобы совпадали у фона и блока: а. Центральные точки. б. Левая верхняя точка. в. Правая нижняя точка.
8. Создайте блок, который меньше чем его фон. Задайте такую особенность расположения фона, чтобы: а. картинка фона была полностью видна в блоке. б. Вся площадь блока была закрыта картинкой (не было пустых мест).
9. Создайте блок, чтобы в нем прокручивался текст (текста было больше чем помещается по размеру блока и было задано свойство overflow:scroll;). Чтобы фон в этом блоке: а. был неподвижен. б. прокручиался вместе с текстом.
10. Реализуйте CSS-параллакс.