Logic for Exercise 1:
----------------------------

1.Logger logger1 = Logger.GetInstance();

Since instance is null, the Logger constructor is called.

A new Logger instance is created and stored in the instance variable.

Message "Logger Initialized" is printed.

2. logger1.Log("First message");

The same instance of Logger is used to log the message.

Output: [LOG]: First message

3. Logger logger2 = Logger.GetInstance();

Since instance is not null, no new object is created.

logger2 now points to the same instance as logger1.

4. logger2.Log("Second message");

Uses the same Logger instance again.

Output: [LOG]: Second message

5. if (logger1 == logger2)

Confirms both references point to the same object in memory.

Output: Singleton confirmed

-----------------------------