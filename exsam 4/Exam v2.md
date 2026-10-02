# Exam (Variant 2)


## Task 1

- What is an Enum? Why is it better than using plain constants or magic numbers?
- What is the default underlying type of an enum? How do you convert a string to an enum value (`Enum.Parse` / `Enum.TryParse`)?

---

- Что такое Enum (перечисление)? Чем оно лучше обычных констант или «магических чисел»?
- Какой тип у enum по умолчанию (underlying type)? Как преобразовать строку в значение enum (`Enum.Parse` / `Enum.TryParse`)?

---

- Enum (шумориш) чист? Барои чӣ он аз константаҳои оддӣ ё «рақамҳои ҷодуӣ» беҳтар аст?
- Навъи пешфарзи enum (underlying type) кадом аст? Чӣ тавр сатрро ба қимати enum табдил додан мумкин аст (`Enum.Parse` / `Enum.TryParse`)?

## Task 2

- What is `DateTime`? What is the difference between `DateTime` and `TimeSpan`?
- How do you calculate the difference between two dates and add days to a date?

---

- Что такое `DateTime`? В чем разница между `DateTime` и `TimeSpan`?
- Как вычислить разницу между двумя датами и добавить дни к дате?

---

- `DateTime` чист? Фарқи байни `DateTime` ва `TimeSpan` чист?
- Чӣ тавр фарқи байни ду санаро ҳисоб кардан ва ба сана рӯз илова кардан мумкин аст?

## Task 3

- What is Exception Handling? What is the purpose of the `try`, `catch` and `finally` blocks?
- Name three common exception types (`FormatException`, `DivideByZeroException`, `IndexOutOfRangeException`) and give an example of when each one occurs. What is the difference between `int.Parse` and `int.TryParse`?

---

- Что такое обработка исключений (Exception Handling)? Для чего нужны блоки `try`, `catch` и `finally`?
- Назовите три распространённых типа исключений (`FormatException`, `DivideByZeroException`, `IndexOutOfRangeException`) и приведите пример, когда каждое из них возникает. В чем разница между `int.Parse` и `int.TryParse`?

---

- Идоракунии истисно (Exception Handling) чист? Блокҳои `try`, `catch` ва `finally` барои чӣ лозиманд?
- Се навъи маъмули истисно (`FormatException`, `DivideByZeroException`, `IndexOutOfRangeException`)-ро номбар кунед ва мисол оваред, ки ҳар яке кай рух медиҳад. Фарқи байни `int.Parse` ва `int.TryParse` чист?

## Task 4

- What is Inheritance and Polymorphism?
- What is the difference between an `abstract class` and an `interface`? When would you choose one over the other?

---

- Что такое наследование и полиморфизм?
- В чем разница между `abstract class` и `interface`? Когда стоит выбрать одно, а когда другое?

---

- Меросбарӣ ва полиморфизм чист?
- Фарқи байни `abstract class` ва `interface` чист? Кай яктоашро интихоб кардан беҳтар аст?

## Task 5

A library needs a simple program to track the status of its books. In this task we implement a `Book` class that uses an `enum` and `DateTime`.

- First, create an enum `BookStatus` with the values: `Available`, `Borrowed`, `Reserved`, `Lost`.
- The `Book` class has the properties `Title` (string), `Author` (string), `Status` (`BookStatus`), `BorrowDate` (`DateTime?`) and `DueDate` (`DateTime?`).
- The `Borrow(int days)` method gives the book to a reader. If the number of days is zero or negative, print an error message to the console and leave the method. If the book is not `Available`, print a message (for example, "The book is already borrowed") and leave the method. Otherwise set the status to `Borrowed`, set `BorrowDate` to the current date and calculate `DueDate` by adding the given number of days.
- The `Return(DateTime returnDate)` method returns the book to the library. If the book is not `Borrowed`, print an error message and return 0. Otherwise calculate the fine for the delay (every overdue day costs 5 somoni; if the book is returned on time, the fine is 0), set the status back to `Available`, clear both dates, and return the fine.
- The `IsOverdue` property returns `true` if the book is borrowed and the current date is later than `DueDate`.

In `Main`, create several books, borrow and return them, and show the result. Read the status, the number of days and the return date from the user as text and convert them using `Enum.Parse`, `int.Parse` and `DateTime.Parse`.

Also do not forget to use exception handling `try` and `catch` when converting the user input (for example: days entered as text, a wrong status name, a date in a wrong format). In the `catch` block just print an error message to the console.

---

Библиотеке нужна простая программа для учета состояния книг. В этой задаче мы реализуем класс `Book`, который использует `enum` и `DateTime`.

- Сначала создайте перечисление `BookStatus` со значениями: `Available`, `Borrowed`, `Reserved`, `Lost`.
- Класс `Book` содержит свойства `Title` (строка), `Author` (строка), `Status` (`BookStatus`), `BorrowDate` (`DateTime?`) и `DueDate` (`DateTime?`).
- Метод `Borrow(int days)` выдает книгу читателю. Если количество дней равно нулю или отрицательное, выведите сообщение об ошибке в консоль и выйдите из метода. Если книга не `Available`, выведите сообщение (например, «Книга уже выдана») и выйдите из метода. Иначе установите статус `Borrowed`, запишите в `BorrowDate` текущую дату и вычислите `DueDate`, добавив указанное количество дней.
- Метод `Return(DateTime returnDate)` возвращает книгу в библиотеку. Если книга не `Borrowed`, выведите сообщение об ошибке и верните 0. Иначе вычислите штраф за просрочку (каждый просроченный день стоит 5 сомони; если книга возвращена вовремя, штраф равен 0), верните статус `Available`, очистите обе даты и верните штраф.
- Свойство `IsOverdue` возвращает `true`, если книга выдана и текущая дата позже `DueDate`.

В методе `Main` создайте несколько книг, выдайте и верните их, выведите результат. Статус, количество дней и дату возврата читайте от пользователя как текст и преобразуйте через `Enum.Parse`, `int.Parse` и `DateTime.Parse`.

Также не забывайте использовать обработку исключений `try` и `catch` при преобразовании введенных данных (например: дни введены текстом, неверное название статуса, дата в неверном формате). В блоке `catch` просто выведите сообщение об ошибке в консоль.

---

Китобхона ба барномаи оддӣ барои назорати ҳолати китобҳо ниёз дорад. Дар ин вазифа мо класси `Book`-ро амалӣ мекунем, ки `enum` ва `DateTime`-ро истифода мебарад.

- Аввал шумориши `BookStatus`-ро бо қиматҳои `Available`, `Borrowed`, `Reserved`, `Lost` эҷод кунед.
- Класси `Book` хосиятҳои `Title` (сатр), `Author` (сатр), `Status` (`BookStatus`), `BorrowDate` (`DateTime?`) ва `DueDate` (`DateTime?`)-ро дорад.
- Методи `Borrow(int days)` китобро ба хонанда медиҳад. Агар шумораи рӯзҳо сифр ё манфӣ бошад, дар консол хабари хато чоп кунед ва аз метод бароед. Агар китоб `Available` набошад, дар консол хабар чоп кунед (масалан, «Китоб аллакай дода шудааст») ва аз метод бароед. Дар акси ҳол ҳолатро ба `Borrowed` иваз кунед, санаи ҷорӣро ба `BorrowDate` нависед ва `DueDate`-ро бо илова кардани шумораи рӯзҳои додашуда ҳисоб кунед.
- Методи `Return(DateTime returnDate)` китобро ба китобхона бармегардонад. Агар китоб `Borrowed` набошад, хабари хато чоп кунед ва 0 баргардонед. Дар акси ҳол ҷаримаи таъхирро ҳисоб кунед (ҳар рӯзи деркарда 5 сомонӣ аст; агар китоб саривақт баргардонида шавад, ҷарима 0 аст), ҳолатро ба `Available` баргардонед, ҳарду санаро тоза кунед ва ҷаримаро баргардонед.
- Хосияти `IsOverdue` `true` бармегардонад, агар китоб дода шуда бошад ва санаи ҷорӣ аз `DueDate` дертар бошад.

Дар `Main` якчанд китоб эҷод кунед, онҳоро диҳед ва баргардонед, натиҷаро чоп кунед. Ҳолат, шумораи рӯзҳо ва санаи баргардониро аз корбар ҳамчун матн хонед ва тавассути `Enum.Parse`, `int.Parse` ва `DateTime.Parse` табдил диҳед.

Инчунин ҳангоми табдили маълумоти воридшуда `try` ва `catch`-ро истифода баред (масалан: рӯзҳо бо матн ворид шуданд, номи ҳолат нодуруст аст, сана бо формати нодуруст ворид шуд). Дар блоки `catch` танҳо хабари хаторо дар консол чоп кунед.

## Task 6

Develop a console-based `Task Planner` in C# that allows users to manage their daily tasks (a simple To-Do list).

**Requirements:**

**`Priority Enum:`**

- Create an enum `Priority` with the values: `Low`, `Medium`, `High`.

**`TaskItem Class:`**

- Create a `TaskItem` class with the following properties:
  - `Id` (integer): Unique identifier of the task.
  - `Title` (string): Title of the task.
  - `Priority` (`Priority`): Priority of the task.
  - `Deadline` (`DateTime`): Date by which the task must be completed.
  - `IsDone` (bool): Whether the task is completed.

**`ITaskService Interface:`**

- Create an interface named `ITaskService` that contains methods for managing tasks:
  - `AddTask:` Adds a new task.
  - `DisplayTasks:` Displays all tasks.
  - `CompleteTask:` Marks a task as completed by Id.
  - `DeleteTask:` Deletes a task by Id.
  - `SearchByTitle:` Searches for a task by title and returns a single matching task or null.
  - `GetByPriority:` Returns a list of tasks with the given priority.

**`TaskService Class:`**

- Create a class named `TaskService` that implements the `ITaskService` interface.
- Include all the methods of the interface in the class.
- For simple errors (a task with this Id already exists, a task was not found, the deadline is in the past) just print an error message to the console.

**`User Interface (Main Program):`**

- Implement a user interface in the main program that continuously presents a menu to the user.
- The menu should include the following options:
  - Add a Task
  - Display All Tasks
  - Complete a Task
  - Delete a Task
  - Search by Title
  - Show Tasks by Priority
  - Exit
- Also do not forget to use exception handling `try` and `catch` when converting the user input (for example: Id entered as text, the date entered in a wrong format, an invalid priority name). In the `catch` block just print an error message to the console.

---

Разработать консольный `Планировщик задач` на C#, который позволяет пользователю управлять ежедневными задачами (простой To-Do список).

**Требования:**

**`Перечисление Priority:`**

- Создать перечисление `Priority` со значениями: `Low`, `Medium`, `High`.

**`Класс TaskItem:`**

- Создать класс `TaskItem` со свойствами:
  - `Id` (целое число): Уникальный идентификатор задачи.
  - `Title` (строка): Название задачи.
  - `Priority` (`Priority`): Приоритет задачи.
  - `Deadline` (`DateTime`): Дата, до которой задачу нужно выполнить.
  - `IsDone` (bool): Выполнена ли задача.

**`Интерфейс ITaskService:`**

- Создать интерфейс `ITaskService`, который будет содержать методы для управления задачами:
  - `AddTask:` Добавляет новую задачу.
  - `DisplayTasks:` Отображает все задачи.
  - `CompleteTask:` Отмечает задачу выполненной по Id.
  - `DeleteTask:` Удаляет задачу по Id.
  - `SearchByTitle:` Ищет задачу по названию и возвращает её или null.
  - `GetByPriority:` Возвращает список задач с указанным приоритетом.

**`Класс TaskService:`**

- Создать класс `TaskService`, который будет реализовывать интерфейс `ITaskService`.
- Включить в класс все методы интерфейса.
- Для простых ошибок (задача с таким Id уже существует, задача не найдена, срок выполнения в прошлом) просто выводите сообщение об ошибке в консоль.

**`Основная программа (Program.cs):`**

- Реализовать пользовательский интерфейс в основной программе, который непрерывно предоставляет пользователю меню.
- Меню должно включать следующие опции:
  - Добавить задачу
  - Показать все задачи
  - Отметить задачу выполненной
  - Удалить задачу
  - Поиск по названию
  - Показать задачи по приоритету
  - Выход
- Также не забывайте использовать обработку исключений `try` и `catch` при преобразовании введенных данных (например: Id введен текстом, дата введена в неверном формате, неверное название приоритета). В блоке `catch` просто выведите сообщение об ошибке в консоль.

---

Таҳияи `Банақшагири вазифаҳо` дар C# дар шакли консолӣ, ки ба корбар имкон медиҳад вазифаҳои ҳаррӯзаи худро идора кунад (рӯйхати оддии To-Do).

**Талабот:**

**`Шумориши Priority:`**

- Шумориши `Priority`-ро бо қиматҳои `Low`, `Medium`, `High` эҷод кунед.

**`Класси TaskItem:`**

- Класси `TaskItem`-ро бо хосиятҳои зерин эҷод кунед:
  - `Id` (бутун): Идентификатори ягонаи вазифа.
  - `Title` (сатр): Номи вазифа.
  - `Priority` (`Priority`): Афзалияти вазифа.
  - `Deadline` (`DateTime`): Санае, ки вазифа бояд то он иҷро шавад.
  - `IsDone` (bool): Оё вазифа иҷро шудааст.

**`Интерфейси ITaskService:`**

- Интерфейси `ITaskService` созед, ки дорои методҳои идоракунии вазифаҳо мебошад:
  - `AddTask:` Вазифаи нав илова мекунад.
  - `DisplayTasks:` Ҳамаи вазифаҳоро нишон медиҳад.
  - `CompleteTask:` Вазифаро аз рӯи Id иҷрошуда қайд мекунад.
  - `DeleteTask:` Вазифаро аз рӯи Id нест мекунад.
  - `SearchByTitle:` Вазифаро аз рӯи ном ҷустуҷӯ мекунад ва онро ё null бармегардонад.
  - `GetByPriority:` Рӯйхати вазифаҳоро бо афзалияти додашуда бармегардонад.

**`Класси TaskService:`**

- Класси `TaskService` эҷод кунед, ки интерфейси `ITaskService`-ро амалӣ мекунад.
- Ҳамаи методҳои интерфейсро ба класс дохил кунед.
- Барои хатоҳои оддӣ (вазифа бо чунин Id аллакай мавҷуд аст, вазифа ёфт нашуд, мӯҳлати иҷро дар гузашта аст) танҳо хабари хаторо дар консол чоп кунед.

**`Барномаи асосӣ (Program.cs):`**

- Интерфейси корбарро дар барномаи асосӣ татбиқ кунед, ки пайваста ба корбар меню пешниҳод мекунад.
- Меню бояд имконоти зеринро дар бар гирад:
  - Вазифа илова кунед
  - Ҳамаи вазифаҳоро нишон диҳед
  - Вазифаро иҷрошуда қайд кунед
  - Вазифаро нест кунед
  - Ҷустуҷӯ аз рӯи ном
  - Вазифаҳоро аз рӯи афзалият нишон диҳед
  - Баромадгоҳ
- Инчунин ҳангоми табдили маълумоти воридшуда `try` ва `catch`-ро истифода баред (масалан: Id бо матн ворид шуд, сана бо формати нодуруст ворид шуд, номи афзалият нодуруст аст). Дар блоки `catch` танҳо хабари хаторо дар консол чоп кунед.
