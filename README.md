# Template for simple message structures to be used for a messaging system

### There are three common types of messages: **commands**, **replies**, and **events**.

A **command** message requests work to be performed immediately or in the future. **command** messages are often imperative: CreateAccount, SubmitPayment, and so on. **Command** messages are sometimes referred to as request messages.

A **reply** message provides the result, or outcome, of a **command** message. **Reply** messages often add the suffix Result or **reply** to differentiate them from their **command** counterparts: CreateAccountResult, SubmitPaymentreply, and so on. **reply** messages are also referred to as response messages. Not all **command** messages result in a **reply** message.

An **event** message is a specialized type of message that tells the message receiver about something that happened in the past. **Event**s are used to indicate new data is available, data has been changed, a threshold has been exceeded, or the state has transitioned to a new value. A good **event** name uses past tense to indicate that an action has already taken place: AccountCreated, PaymentSubmitted, and so on.

<fieldset>

<span style="color:red">**Event Driven Architecture Pitfall #1:**</span> Note that messages are immutable, meaning that once they are published, they may not be modified.

Therefore, a message that requires modification or transformation to another format must be republished as a new message. Consider using correlation identifiers when this occurs to help with tracing and troubleshooting.

</fieldset>
<br/>

https://hookdeck.com/blog/event-driven-architectrure-fundamentals-pitfalls#:~:text=There%20are%20three%20common%20types,referred%20to%20as%20request%20messages.