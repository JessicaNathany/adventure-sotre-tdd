# :pencil: :blue_book: Tests

The purpose of this repository is to share studies on tests and some experiments. Here I put some examples likes unit test, tdd and integration test. 

## Some business rules about this application :clipboard:

## Customer 
##### 1. A customer to needs to have data validated
##### 2. Verfiy if the cutomer exist on the plataform

## Order (Method CloseOrder) 
##### 0. Verfiy if the order existi on the plataform
##### 1. The customer can only rescue products in they are in stock
##### 2. A customer cannot redeem  the products when their are lower than the products points 
##### 3. A customer cannot redeem  the products if he had no points

## Order (Add item)
##### 0. Verfiy if the order existi on the plataform
##### 1. Before adding an item to the cart it is necessary to calculate the total order amount
##### 2. If an item is already on the list, then add the item quantity to the order

## Order (Update item)
##### 0. Verfiy if the order existi on the plataform
##### 1. The item must be in the list to be updated
##### 2. Before to update an item it is necessary to calculate the total order amount

## Order (Remove item)
##### 0. Verfiy if the order existi on the plataform
##### 1. The item must be in the list to be removed
##### 2. Before to delete an item it is necessary to calculate the total order amount


## Note :bulb:
##### You can create a shortcut (snippet) for start your test method. This is repository has a file name xunit_fact.snippet.
##### In your **Visual Studio slect the menu Tools - Code sneept manager and import this file**. You can use your keyboard (tab tab)  for shortcut

