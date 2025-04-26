import { useState } from "react";

function MovieList() {
    const [movies] = useState([
        { id: 1, title: "Inception" },
        { id: 2, title: "Interstellar" },
    ]);

    return (
        <div>
            <h2>Movie Watchlist</h2>
            <ul>
                {movies.map(movie => (
                    <li key={movie.id}>{movie.title}</li>
                ))}
            </ul>
        </div>
    );
}

export default MovieList;