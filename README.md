# Unexpected Mutable Variable Behavior in F#

This repository demonstrates a subtle bug related to mutable variables in F#. The code intends to add two numbers, but due to unintended side effects from modifying mutable variables, it produces an incorrect result.  The solution showcases a functional approach to avoid this issue.

## Bug Description

The `add` function modifies the global variables `x` and `y` during calculation, leading to unexpected values in the final output. This highlights a common pitfall when dealing with mutable state in F#.

## Solution

The solution provides an alternative implementation using immutable values and pattern matching. This approach avoids side effects and produces the correct result.