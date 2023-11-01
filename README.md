## The general store program

Extension activity as a part of a Cyber Security & Software Engineering Skills Bootcamp.

## Possible expansions

Consider making the below expansions to consolidate your programming knowledge and skills. However, ultimately, it's up to you...get creative!

1. Add an item to the general store. This will involve adding code to the switch statement (a conditional statement similar to the if statements we have already seen) and in a few other places as well. The item can be anything you like!

2. At the moment we can only buy one item from the store. Wrap some of the code up in a loop so that a player/shopper can buy multiple items so long as they have some coins remaining (E.g., playerCoins > 0).

3. Take a look at this documentation: https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/statements/selection-statements. See if you can find out any new information regarding the switch statement. Is there anyway we can update our statement to improve it so that it better handles the situation where a player/shopper enters a letter it doesn't recognize?

4. Take a look at this documentation: https://learn.microsoft.com/en-us/dotnet/api/system.string.toupper?view=net-7.0. See if you can figure out how to make it so that the program can better handle both upper and lower case letters as input (without adding cases to the switch statement).

5. Maybe we should give our players a discount if they give the shopkeeper a friendly greeting. See if you can have a go at implementing this using `Console.ReadLine();` and an `if` statement that makes a decision based on the player's input.

6. What exists beyond the general store? That's up to you! Have a go at refactoring/changing the code so that the general store exists as an object that the player can interact with. From there, why not have a go at making a `Player` object and fleshing out the general store program into a fully fledged game of your own design.
