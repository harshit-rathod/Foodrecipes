CREATE TABLE Food_recipes (
 id int NOT NULL IDENTITY PRIMARY KEY,
 title VARCHAR(MAX) NULL,
 ingredients VARCHAR(MAX) NULL,
 instructions VARCHAR(MAX) NULL,
 preparation_time int NULL,
 difficulty_level varchar(100)
CHECK(difficulty_level IN ('easy','average','challenging')),
 category_breakfast BIT NULL,
 category_lunch BIT NULL,
 category_dinner BIT NULL,
 category_dessert BIT NULL,
 );