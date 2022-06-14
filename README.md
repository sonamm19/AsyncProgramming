# AsyncProgramming
Asynchronous programming is where a programmer will choose to run some of his code on a separate thread from the main thread of execution and then notify the main thread on it's completion.

Use the async and await keywords to make user interface more responsive and to speed up code's operation. 
You will also see how to turn an existing method from being synchronous to asynchronous. 
Along the way, we will cover best practices and how to make sure our application behaves like we expect after we make a part of it asynchronous.

Download contents from given url. It has been done 3 ways

**1. Normal method** (Synchronous) - Download contents and show result at once. User is blocked doing other operations as everything is being done on main thread (ThreadId = 1)

**2. Async method** Download contents and show result as we download. User is not blocked doing other operations. tasks 

**3. Parallel Async Method**  Download contents and show result all at once. User is not blocked doing other operations.

Point of an async Task is to let it execute in background without locking the main thread.
