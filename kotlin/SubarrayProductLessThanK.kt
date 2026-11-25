fun numSubarrayProductLessThanK(nums: IntArray, k: Int): Int {
    if (k <= 1) return 0 // every product is >= 1, nothing can be < 1

    var count = 0
    var product = 1
    var left = 0

    for (right in nums.indices) {
        product *= nums[right]

        while (product >= k) { // shrink until the window product is valid again
            product /= nums[left]
            left++
        }

        count += right - left + 1 // valid subarrays ending at `right`
    }
    return count
}

fun main() {
    println(numSubarrayProductLessThanK(intArrayOf(10, 5, 2, 6), 100)) // 8
    println(numSubarrayProductLessThanK(intArrayOf(1, 2, 3), 0))       // 0
    println(numSubarrayProductLessThanK(intArrayOf(1, 1, 1), 2))       // 6
}
