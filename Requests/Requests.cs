using System;
using System.Collections.Generic;
using System.Text;

namespace Movies.Contracts.Requests;

public class CreateMovieRequest
{
    public required string Title { get; init; }
    public required int YearOfRelease { get; init; }
    public required IEnumerable<string> Genres { get; init; } = [];
}

public class UpdateMovieRequest
{
    public required string Title { get; init; }
    public required int YearOfRelease { get; init; }
    public required IEnumerable<string> Genres { get; init; } = [];
}
