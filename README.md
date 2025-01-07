# gimica-test
Test task for Gimica/JustPlay


- Problem 1

Consider the following code snippet below:
class Mover : MonoBehaviour
{
  Vector3 target;
  float speed;
  void Update()
  {
  }
}
Finish this code so the GameObject containing this script moves with constant speed towards the target, and stop moving once it reaches 1.0, or less, units of distance. If you have any suggestions on how to optimize the code for better performance, share some best practices or enhance its style, please add comments or annotations.


- Problem 2

Create a simple Unity project with one scene containing a UI-based currency counter system. You can do it with any version of unity.
Requirements:
	•	Scene Setup:
	•	Create a single Unity scene that contains a UI Canvas.
	•	The canvas should display three different currency counters: Gold, Energy, and Crystals.
	•	Currency Counter Structure:
	•	Each currency counter should have the following elements:
	•	An icon representing the currency (e.g., a gold coin for Gold).
	•	A text label displaying the current amount of the currency.
	•	A distinct text color for each type of currency (e.g., Gold = yellow, Energy = green, Crystals = blue).
	•	An optional "Add" button that allows the user to increment the currency amount by a predefined value (e.g., +10).
	•	Write a script for a currency counter that displays the current amount of currency and allows for updates to that amount
    

- Problem 3

You are given an array of prices where prices[i] is the price of a given stock on the i-th day.
You want to maximize your profit by choosing a single day to buy one stock and choosing a different day in the future to sell that stock.
Return the maximum profit you can achieve from this transaction. If you cannot achieve any profit, return 0.

Example 1
Input: prices = [7,1,5,3,6,4]
Output: 5
Explanation: Buy on day 2 (price = 1) and sell on day 5 (price = 6), profit = 6-1 = 5.

Note that buying on day 2 and selling on day 1 is not allowed because you must buy before you sell.

Example 2
Input: prices = [7,6,4,3,1]
Output: 0
Explanation: In this case, no transactions are done and the max profit = 0.

Constraints
1 <= prices.length <= 105
0 <= prices[i] <= 104

Code
public class Solution {
    public int MaxProfit(int[] prices) {
    }
}

