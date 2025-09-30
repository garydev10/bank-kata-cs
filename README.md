# Instructions
Write a class named Account that implements the following public interface:
```csharp
public interface AccountService
{
    void deposit(int amount) 
    void withdraw(int amount) 
    void printStatement()
}
```
# Rules
You cannot change the public interface of this class.
# Desired Behaviour
Here's the specification for an acceptance test that expresses the desired behaviour for this  
     
**Given** a client makes a deposit of 1000 on 10-01-2012  
**And** a deposit of 2000 on 13-01-2012  
**And** a withdrawal of 500 on 14-01-2012  
**When** they print their bank statement  
**Then** they would see:  

```
Date       || Amount || Balance
14/01/2012 || -500   || 2500
13/01/2012 || 2000   || 3000
10/01/2012 || 1000   || 1000
```

# Reference
[Codurance Bank Kata](https://www.codurance.com/katas/bank)  
[C# Bank Kata](https://github.com/Gryff/bank-kata) by [Liam Griffin-Jowett](https://codurance.com/publications/author/liam-griffin/)