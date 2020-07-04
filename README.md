# BoilerPlateXamarinForms
This is Pure MVVM architecture benificial for beginners to understand the flow.

Code Contains
1. DI for services and viewmodels using ViewModelLocator and TinyIOC
2. MVVM DesignPattern
3. Api Call Using Services and Interface.
4.Generic methods for GET POST PUT rest calls
5.Using AutoWire to bind the ViewModel with the View.

Point to Remember

To bind the View to the ViewModel without using BindingContext , we need to follow some naming constraints..

eg:-
wrong Naming 
view:- CountryListPage
viewmodel :- CountryListViewModel

correct Naming
view:- CountryListView
viewmodel:- CountryListViewModel


