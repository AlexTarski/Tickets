# Tickets

Task for this project:
find the quantity of "lucky" tickets with a given sum of digits among the tickets, which numbers consist of 2N digits.

A ticket is "lucky" when the sum of its first half of digits equals the sum of its other half of digits.

For example, tickets with the next numbers are "lucky": 0110, 1010, 999999, 1203.

The Solve method of the TicketsTask class calculates the count of the tickets mentioned above.

Input:
halfLen: half of the number digits (halfLen = 2(N), then the number consists of 4 (2N) digits).
totalSum: sum of all number digits.

Output:
Quantity of "lucky" tickets with a given sum of digits among the tickets, which numbers consist of 2N digits.