﻿using api_cinema_challenge.DTO;
using api_cinema_challenge.Endpoints;
using api_cinema_challenge.Models;

namespace api_cinema_challenge.Repositories
{
    public interface ICinemaRepository
    {
        Task<IEnumerable<Customer>> GetAllCustomers();

        Task<Customer?> CreateCustomer(string name, string email, string phone, CreateCustomerPayload payload);

        Task<Customer?> UpdateCustomer(int id, string name, string email, string phone, UpdateCustomerPayload payload);

        Task<bool> DeleteCustomer(int id);





        Task<IEnumerable<Movie>> GetAllMovies();

        // Task<Movie?> CreateMovie(string title, string rating, string description, int runTimeMinutes, CreateMoviePayload payload);

        //Task<Movie?> UpdateMovie(int id, string title, string rating, string description, int runTimeMinutes, UpdateMoviePayload payload);
        Task<Movie?> CreateMovie(CreateMoviePayload payload);

        Task<Movie?> UpdateMovie(int id, UpdateMoviePayload payload);

        Task<bool> DeleteMovie(int id);






        Task<ICollection<Screening>> GetAllScreeningsByMovieID(int movieId);

        Task<Screening?> CreateScreening(CreateScreeningPayload payload);





        Task<Ticket?> CreateTicket(CreateTicketPayload payload);
        Task<ICollection<Ticket>> GetAllTicketsByCustomerAndScreeningID(int customerId, int screeningId);

        Task<ICollection<Ticket>> GetAllTicketsByCustomerID(int customerId);

        Task<ICollection<Ticket>> GetAllTicketsByScreeningID(int screeningId);

    }
}
