<h1>Описание тестового задания</h1>

"Тестовое задание, желательно выполнить на C#, результат выложите на GitHub, будут вопросы - пишите. Так же напишите ориентировочный срок сколько вам потребуется на выполнение задания.
Есть круглый стол для игры в покер для каждого из сидящих за столом было одинаковое количество фишек.
Но кто-то переставил все фишки так, что они перестали быть равномерно распределенными!
Теперь нужно перераспределить фишки так, чтобы у каждого места был одинаковое количество
Но чтобы не потерять ни одной фишки в процессе передвигать фишки можно только между соседними местами.
Более того, надо передвигать фишки только по одной за раз. Каково минимальное количество ходов фишек
Что нужно будет сделать, чтобы вернуть равное количество?"

<h1>Ожидаемое поведение</h1>

<h3>Test 1</h3>

<h4>Input:</h4>
```chips: [1, 5, 9, 10, 5]```

Expected Output: ```12```

<h3>Test 2</h3>
<h4>Input:</h4>
```chips: [1, 2, 3]```

Expected Output: ```1```

<h3>Test 3</h3>

<h4>Input:</h4>
```chips: [0, 1, 1, 1, 1, 1, 1, 1, 1, 2]```

Expected Output: ```1```

Данные тесты предоставлены в проекте ```PokerResolverTests``` в файле ```PokerHelperTests```