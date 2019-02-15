import React, { Component } from 'react';

export class WatchList extends Component {
  static displayName = WatchList.name;

  constructor (props) {
    super(props);
    this.state = { movies: [], loading: true };

    fetch('api/Movie/GetWatchList')
      .then(response => response.json())
      .then(data => {
        this.setState({ movies: data, loading: false });
      });
  }

    static renderWatchListTable(movies) {

    return (
      <table className='table table-striped'>
        <thead>
          <tr>
            <th>Title</th>
          </tr>
        </thead>
        <tbody>
          {movies.map(movie =>
            <tr key={movie.id}>
              <td>{movie.originalTitle}</td>
            </tr>
          )}
        </tbody>
      </table>
    );
  }

  render () {
    let contents = this.state.loading
      ? <p><em>Loading...</em></p>
      : WatchList.renderWatchListTable(this.state.movies);

    return (
      <div>
        <h5>My WatchList</h5>
        {contents}
      </div>
    );
  }
}
