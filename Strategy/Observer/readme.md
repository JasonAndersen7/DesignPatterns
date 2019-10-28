The Observer pattern seeks to allow objects to notify their observers when their internal state changes.

The Participants
The Subject knows its Observers and provides an interface for attaching or detaching any number of Observer objects.
The ConcreteSubject objects store the states of interest to the Observers and are responsible for sending a notification when the ConcreteSubject's state changes.
The Observer defines an updating interface for objects that should be notified of changes in a Subject.
The ConcreteObserver objects maintain a reference to a ConcreteSubject and implement the Observer updating interface to keep its state consistent with that of the Subject's.
A Delicious Example
To model this, let's imagine that we need a system to model the fluctuating prices of vegetables at our local market (e.g. a stock market, but for vegetables). On some days, the vegetables will be more expensive than on other days, due to factors like the size of the harvest or the size of the vegetables themselves. Further, we need to allow restaurants to watch the prices and place an order when the price for a particular vegetable falls below a specified threshold, which is different for each restaurant.


