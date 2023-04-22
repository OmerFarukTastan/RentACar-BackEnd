using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using Core.Entities.Concrete;
using Entities.Concrete;

namespace Business.Constants
{
    public static class Messages
    {
        public static string CarAdded = "Car added";
        public static string Deleted = "Deleted Successfully";
        public static string Updated = "Updated Successfully";
        public static string BrandAdded = "Brand added";
        public static string ColorAdded = "Color added";
        public static string CarNameInvalid = "The car name must be at least 2 characters.";
        public static string BrandNameEmpty = "Brand name cannot be empty!";
        public static string ColorNameEmpty = "The color name of the car cannot be empty!";
        public static string CarsListed = "Cars are listed";

        public static string AddedUser = "User is added";
        public static string ListedUsers = "User is listed";
        public static string UpdatedUser = "User is updated";
        public static string DeletedUser = "User is deleted";

        public static string AddedCustomer = "Customer is added";
        public static string ListedCustomers = "Customers are listed";
        public static string UpdatedCustomer = "Customer is updated";
        public static string DeletedCustomer = "Customer is deleted";

        public static string ListedRentals = "Rentals info is listed";
        public static string UpdatedRental = "Rental info is updated";
        public static string DeletedRental = "Rental info is deleted";
        public static string NotDeliveredRental = "Rental can't be done";
        public static string DeliveredRental = "Rental is successful";

        public static string CarImagesLimitExceeded = "A car can have 5 images as maximum";
        public static string CarNotExisted = "Car don't exist";
        public static string ImageUploaded = "Image uploaded successfully";
        public static string ImageDeleted = "Image deleted successfully";
        public static string ImageUpdated = "Image updated successfully";
        public static string SuccessfullyRetrieved = "Image retrieved successfully";

        public static string UserRegistered = "User is registered successfully";
        public static string AuthorizationDenied = "You have no authorization";
        public static string PasswordError = "Wrong password";
        public static string UserNotFound = "User don't exists";
        public static string SuccessfulLogin = "Login is successful";
        public static string UserAlreadyExists = "User is already exists";
        public static string AccessTokenCreated = "Access token is created";

        public static string CarIsNotAvailable = "Car is rented by other customer";
        public static string PayIsSuccessfull = "Payment is successful";
        public static string CardInformationIsIncorrect = "Card information is wrong";

        public static string ListedSuccessful = "Listed Succesfully ";

        public static string UserPasswordUpdated = "Password is changed";
    }
}
