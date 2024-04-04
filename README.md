# Description
The code for the calculator which we created in the previous task is given below. Your task is to add checks to ensure proper user input.

Add a check to make sure that the user enters appropriate input for the `opr` variable. The input should not be empty and should only be equal to `+`, `-`, `/` or `*`. In case of wrong input, it should prompt the user again for entry. Similar to point 1, add checks for `first` and `second`. Make sure the user enters a valid number.

There can be multiple ways to do this. As long as it satisfies the condition, it is a valid solution. Ideally there should be 3 separate try-catch statements for the 3 inputs. You can put all the try-catch statements in a single loop, or separate loops, it is up to your preference.

**Note:** The `TryParse` method is not used in these tasks because it is more useful to practice the `try-catch` statements as they are relevant for the upcoming topics.

### Hints
> **Hint:** Enclose the `try-catch` check into an infinite while loop and break the loop after the input is successfully parsed. This way you can ensure that the program re-prompts the user in case of wrong input.
