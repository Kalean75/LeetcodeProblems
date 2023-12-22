## 2706. Buy Two Chocolates

You are given an integer array prices representing the prices of various chocolates in a store. You are also given a single integer money, which represents your initial amount of money.

You must buy exactly two chocolates in such a way that you still have some non-negative leftover money. You would like to minimize the sum of the prices of the two chocolates you buy.

Return the amount of money you will have leftover after buying the two chocolates. If there is no way for you to buy two chocolates without ending up in debt, return money. Note that the leftover must be non-negative.

Solution:
    This is easily achieved by sorting the array and then subtracting the first 2 values from the money. If money is less than 0, you return the original value. Otherwise, you return the new value.

 