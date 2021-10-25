select name+'('+ upper(substring(occupation, 1, 1)) +')' 
  from OCCUPATIONS order by name, occupation
select 'There are a total of ' + 
      convert(varchar, a) +' '+ 
      lower(convert(varchar, occupation)) +'s.' 
  from (select count(occupation) as a, 
  occupation from occupations 
  group by occupation) tb 
  order by a, occupation
