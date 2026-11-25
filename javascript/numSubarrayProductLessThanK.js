function numSubarrayProductLessThanK(nums, k) {
  if (k <= 1) return 0; // every product is >= 1, nothing can be < 1

  let count = 0;
  let product = 1;
  let left = 0;

  for (let right = 0; right < nums.length; right++) {
    product *= nums[right];

    while (product >= k) { // shrink until the window product is valid again
      product /= nums[left];
      left++;
    }

    count += right - left + 1; // valid subarrays ending at `right`
  }
  return count;
}

console.log(numSubarrayProductLessThanK([10, 5, 2, 6], 100)); // 8
console.log(numSubarrayProductLessThanK([1, 2, 3], 0));       // 0
console.log(numSubarrayProductLessThanK([1, 1, 1], 2));       // 6

module.exports = { numSubarrayProductLessThanK };
