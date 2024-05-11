-- Create the Receptionist table
CREATE TABLE Receptionist (
    Username TEXT NOT NULL PRIMARY KEY,
    Password TEXT NOT NULL
);

-- Create the Drinks table
CREATE TABLE Drinks (
    DrinkID INTEGER PRIMARY KEY,
    Name TEXT NOT NULL,
    Price REAL NOT NULL
);

-- Create the Foods table
CREATE TABLE Foods (
    FoodID INTEGER PRIMARY KEY,
    Name TEXT NOT NULL,
    Price REAL NOT NULL
);

-- Create the Services table
CREATE TABLE Services (
    ServiceID INTEGER PRIMARY KEY,
    Name TEXT NOT NULL,
    Price REAL NOT NULL
);

-- Create the Room table
CREATE TABLE Room (
    RoomID INTEGER PRIMARY KEY,
    GuestName TEXT NOT NULL,
    CheckinDateTime TEXT NOT NULL,
    CheckoutDateTime TEXT NOT NULL,
    MaintenanceStatus TEXT NOT NULL
);

-- Create the RoomDrinks table
CREATE TABLE RoomDrinks (
    RoomID INTEGER NOT NULL,
    DrinkID INTEGER NOT NULL,
    FOREIGN KEY (RoomID) REFERENCES Room(RoomID),
    FOREIGN KEY (DrinkID) REFERENCES Drinks(DrinkID),
    PRIMARY KEY (RoomID, DrinkID)
);

-- Create the RoomFoods table
CREATE TABLE RoomFoods (
    RoomID INTEGER NOT NULL,
    FoodID INTEGER NOT NULL,
    FOREIGN KEY (RoomID) REFERENCES Room(RoomID),
    FOREIGN KEY (FoodID) REFERENCES Foods(FoodID),
    PRIMARY KEY (RoomID, FoodID)
);

-- Create the RoomServices table
CREATE TABLE RoomServices (
    RoomID INTEGER NOT NULL,
    ServiceID INTEGER NOT NULL,
    FOREIGN KEY (RoomID) REFERENCES Room(RoomID),
    FOREIGN KEY (ServiceID) REFERENCES Services(ServiceID),
    PRIMARY KEY (RoomID, ServiceID)
);
