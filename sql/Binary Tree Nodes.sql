select case
        when p is null 
        then concat(merda.n, ' Root')
        when n in (select distinct bosta.p from BST bosta) 
        then concat(merda.n, " Inner")
      else concat(merda.n, " Leaf") end
  from BST merda
  order by merda.n
