create table products (product_id int primary key, product_name text);

insert into products values (1, 'Хлеб'), (2, 'Корм для кошек'), (3, 'Купон');

create table caterogies (category_id int primary key, category_name text);

insert into caterogies values (1, 'Продукты питания'), (2, 'Товары для животных');


 create table ProductCategory(product_id int foreign key references products(product_id),
							  category_id int foreign key references caterogies(category_id) 
							  primary key (product_id, category_id));

insert into ProductCategory values (1, 1), (2, 2);

select pr.product_name, ca.category_name from products pr
left join ProductCategory pc on pr.product_id = pc.product_id
left join caterogies ca on pc.category_id = ca.category_id;