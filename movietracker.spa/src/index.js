import React from 'react';
import ReactDOM from 'react-dom';
import './index.css';
import App from './App';
import reportWebVitals from './reportWebVitals';
import { BrowserRouter } from 'react-router-dom';
import { createBrowserHistory } from 'history';

import { stripTrailingSlash } from './StringHelper';

const baseUrl = document.getElementsByTagName('base')[0].getAttribute('href');
const rootElement = document.getElementById('root');

console.log('environment', process.env.NODE_ENV);
if (process.env.NODE_ENV !== 'development') {
  console.log = () => { };
}

export const history = createBrowserHistory({
  baseName: process.env.PUBLIC_URL
});

ReactDOM.render(
  <React.StrictMode>
    <BrowserRouter basename={stripTrailingSlash(baseUrl)}>
      <App />
    </BrowserRouter>
  </React.StrictMode>,
  rootElement
);

// If you want to start measuring performance in your app, pass a function
// to log results (for example: reportWebVitals(console.log))
// or send to an analytics endpoint. Learn more: https://bit.ly/CRA-vitals
reportWebVitals();