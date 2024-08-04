# Observer

> Observer is a behavioral design pattern that lets you define a subscription mechanism to notify multiple objects about any events that happen to the object they’re observing.

<p align="center">
  <img width="640" src="https://refactoring.guru/images/patterns/content/observer/observer.png" />
</p>

## Structure

<p align="center">
  <img width="610" src="https://refactoring.guru/images/patterns/diagrams/observer/structure.png" />
</p>

## Applicability

- Use the Observer pattern when changes to the state of one object may require changing other objects, and the actual set of objects is unknown beforehand or changes dynamically.
- Use the pattern when some objects in your app must observe others, but only for a limited time or in specific cases.

## Pros and Cons
- Open/Closed Principle. You can introduce new subscriber classes without having to change the publisher’s code (and vice versa if there’s a publisher interface).
- You can establish relations between objects at runtime.
<br/><br/>  
- Subscribers are notified in random order.