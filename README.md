[![Instagram](https://img.shields.io/badge/Instagram-lacopydepastel-E4405F?style=for-the-badge&logo=instagram&logoColor=white)](https://instagram.com/lacopydepastel)
[![YouTube](https://img.shields.io/badge/YouTube-%40rvorine-FF0000?style=for-the-badge&logo=youtube&logoColor=white)](https://youtube.com/@rvorine)

# Subarray Product Less Than K (LeetCode 713)

## Problem

Given an array of positive integers `nums` and an integer `k`, return the **number of contiguous subarrays** whose product is **strictly less than `k`**.

Example:

```
Input:  nums = [10,5,2,6], k = 100     Output: 8
        // [10] [5] [2] [6] [10,5] [5,2] [2,6] [5,2,6]
Input:  nums = [1,2,3],    k = 0       Output: 0
Input:  nums = [1,1,1],    k = 2       Output: 6
```

## Solution

**Sliding window** — all numbers are positive, so the product only grows when the window grows and only shrinks when it shrinks.

1. Keep a running `product` of the window `[left, right]`.
2. Extend `right` and multiply the new number in.
3. While `product >= k`, divide out `nums[left]` and move `left` forward.
4. Every subarray that **ends at `right`** and starts anywhere in `[left, right]` is valid, and there are `right - left + 1` of them. Add that to the count.

Counting subarrays by their right end means each valid subarray is counted exactly once, without listing them.

Edge case: if `k <= 1`, no product can be below `k` (every product is at least 1), so return `0`. This also stops the window from shrinking past empty.

**Time:** O(n) — each index enters and leaves the window at most once.
**Space:** O(1).

## Implementations

| Language | File |
|---|---|
| Python | [`python/num_subarray_product_less_than_k.py`](python/num_subarray_product_less_than_k.py) |
| Java | [`java/SubarrayProductLessThanK.java`](java/SubarrayProductLessThanK.java) |
| Kotlin | [`kotlin/SubarrayProductLessThanK.kt`](kotlin/SubarrayProductLessThanK.kt) |
| JavaScript | [`javascript/numSubarrayProductLessThanK.js`](javascript/numSubarrayProductLessThanK.js) |
| C# | [`csharp/SubarrayProductLessThanK.cs`](csharp/SubarrayProductLessThanK.cs) |
