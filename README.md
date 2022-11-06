# Figure

Здесь расположена библиотека с фигурами (треугольник и круг).
Реализован прецедент нахождения площади данных фигур. Приложены тесты и пример использования

Для решения задачи условимся, что есть три таблицы:
Таблица Продукты: ID, Продукт ...
Таблица Категории: ID, Категория ...
Таблица Продукты: ID_Продукта, ID_Категории

select Product.[Name], Category.[Name]
from (Product left join [Product-Category] on (Product.ID = [Product-Category].ID_Product)) 
			  left join Category on (ID_Category = Category.ID)
