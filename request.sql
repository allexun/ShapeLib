select p.name, c.name
from products as p
    left join products_categories as pc on pc.product_id = p.id
    inner join categories as c on c.id = pc.category_id;