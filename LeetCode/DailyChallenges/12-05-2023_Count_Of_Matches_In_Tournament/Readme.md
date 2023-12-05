Problem:
You are given an integer n, the number of teams in a tournament that has strange rules:

If the current number of teams is even, each team gets paired with another team. A total of n / 2 matches are played, and n / 2 teams advance to the next round.
If the current number of teams is odd, one team randomly advances in the tournament, and the rest gets paired. A total of (n - 1) / 2 matches are played, and (n - 1) / 2 + 1 teams advance to the next round.
Return the number of matches played in the tournament until a winner is decided.

Solution:
    This is easily achieved by a simple modulo check. While n is greater than one, we can simply divide n by 2 and that gives us the number of matches for the current "round", and we keep repeating and adding these to the total number of matches until the number of teams is less than 2.