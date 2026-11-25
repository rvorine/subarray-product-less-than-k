def num_subarray_product_less_than_k(nums, k):
    if k <= 1:  # every product is >= 1, nothing can be < 1
        return 0

    count = 0
    product = 1
    left = 0

    for right, num in enumerate(nums):
        product *= num

        while product >= k:  # shrink until the window product is valid again
            product //= nums[left]
            left += 1

        count += right - left + 1  # valid subarrays ending at `right`

    return count


if __name__ == "__main__":
    print(num_subarray_product_less_than_k([10, 5, 2, 6], 100))  # 8
    print(num_subarray_product_less_than_k([1, 2, 3], 0))        # 0
    print(num_subarray_product_less_than_k([1, 1, 1], 2))        # 6
