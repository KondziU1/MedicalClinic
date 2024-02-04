# Projekt zarządzania wizytami medycznymi moduł administracja

Ten projekt ma na celu stworzenie aplikacji do zarządzania wizytami medycznymi. Aplikacja będzie przechowywać informacje o pacjentach, lekarzach, gabinetach medycznych i ich specjalizacjach oraz harmonogramie wizyt.

## Helpers
Ten folder zawiera niektóre klasy pomocnicze, które są używane w całej aplikacji:
* **AppointmentHelper**- Klasa zapewniająca niektóre metody pomocnicze do pracy z danymi dotyczącymi wizyt.
* **AuthHelper**- Klasa zapewniająca niektóre metody pomocnicze do uwierzytelniania i autoryzacji.
* **DatabaseHelper**- Klasa zapewniająca niektóre metody pomocnicze do pracy z bazą danych.
* **EmployeeHelper**- Klasa zapewniająca niektóre metody pomocnicze do pracy z danymi dotyczącymi pracowników.
* **OfficeHelper**- Klasa zapewniająca niektóre metody pomocnicze do pracy z danymi dotyczącymi placówek medycznych.
* **RoleHelper**- Klasa zapewniająca niektóre metody pomocnicze do pracy z danymi dotyczącymi ról.
* **UserHelper**- Klasa zapewniająca niektóre metody pomocnicze do pracy z danymi dotyczącymi użytkowników.
* **ValidationHelper**- Klasa zapewniająca niektóre metody pomocnicze do sprawdzania poprawności wprowadzanych danych przez użytkownika.
## Modele
Ten folder zawiera modele danych, które są używane w całej aplikacji:
* **Appointment** - model reprezentujący wizytę medyczną
* **Calendar** - model reprezentujący kalendarz, na którym umieszczone są wizyty medyczne
* **Employee** - model reprezentujący lekarza lub personel medyczny
* **EmployeeSpecialization**- model reprezentująca specjalizację pracownika
* **Office** - model reprezentujący gabinety
* **Patient** - model reprezentujący pacjenta
* **Role** - model reprezentujący rolę pracownika
* **Specialization** - model reprezentujący specjalizację lekarza lub personelu medycznego
* **User**- model reprezentująca użytkownika.
* 
## Serwisy

Ten folder zawiera klasy serwisowe, które są używane do interakcji z bazą danych:
* **AppointmentService**- serwis obsługujący operacje związane z spotkaniami
* **EmployeeService** - serwis obsługujący operacje związane z pracownikami medycznymi
* **OfficeService** - serwis obsługujący operacje związane z gabinetami medycznymi
* **PatientService** - serwis obsługujący operacje związane z pacjentami
* **RoleService** - serwis obsługujący operacje związane z rolami pracowników medycznych
* **SpecializationService** - serwis obsługujący operacje związane z specjalizacjami pracowników medycznych
* **UserService**-  serwis obsługujący operacje związane z użytkownikami

***W każdej klasie serwisowej znajdują się metody umożliwiające wykonywanie podstawowych operacji CRUD (Create, Read, Update, Delete) na danych przechowywanych w bazie danych.***
