# Shopping System

This is a shopping website project that aims to provide a platform for users to buy and sell items. The website consists of several components, including users, items, delivery, and stores. Each component has specific attributes and relationships, as described below.

## Components

### Users

Users are individuals who interact with the shopping website. Each user has the following attributes:

<ul>
  <li> Full Name: The user's full name. </li>
  <li> ID: Unique identifier for the user. </li>
  <li> Phone Number(s): One or more phone numbers associated with the user. </li>
  <li> Email: The user's email address. </li>
  <li> Password: The user's password for account authentication. </li>
  <li> Location: The user's physical address. </li>
</ul>

Users can belong to one of three types:

<ol>
  <li> Buyer: Users who purchase items from stores. </li>
  <li> Seller: Users who own and manage stores. </li>
  <li> Delivery: Users responsible for delivering purchased items to buyers. </li>
</ol>

Additionally, if a user belongs to the "delivery" type, their car type will be stored.

### Stores

Stores are owned by sellers and contain items available for sale. Each store has the following attributes:

<ul>
  <li> Name: The store's name. </li>
  <li> ID: Unique identifier for the store. </li>
  <li> Email: The store's email address. </li>
  <li> Rating: The rating or feedback score of the store. </li>
  <li> Total Sold: The total number of items sold by the store. </li>
  <li> Current Quantity: The current quantity of items available in the store. </li>
</ul>

Each seller owns exactly one store.

### Items

Items represent individual products available for sale in the stores. Each item has the following attributes:

<ul>
  <li> Name: The item's name. </li>
  <li> ID: Unique identifier for the item. </li>
  <li> Price: The price of the item. </li>
  <li> Quantity: The number of available units for the item. </li>
</ul>

Items are associated with one store. They can be sold to buyers, triggering a delivery process.

### Purchase and Delivery

When a buyer purchases an item, it requires delivery to the buyer's location. The delivery process works as follows:

<ul>
  <li> Each sold item needs to be delivered to its respective buyer. </li>
  <li> A delivery can handle the delivery of multiple items to multiple buyers. </li>
</ul>

### Conclusion

This shopping website project aims to provide a comprehensive platform for users, stores, items, and delivery management. By implementing this system, users can buy and sell items, with the purchased items being delivered to buyers. The project ensures the proper association of items with stores, and the management of user roles and store ownership.
