select h.hacker_id, h.name 
  from Hackers h
    inner join Submissions sb on sb.hacker_id = h.hacker_id
    inner join Challenges c on c.challenge_id = sb.challenge_id
    inner join difficulty d on d.difficulty_level = c.difficulty_level and d.score = sb.score
  group by h.name, h.hacker_id
  having count(h.hacker_id) > 1
  order by count(h.hacker_id) desc, h.hacker_id asc
