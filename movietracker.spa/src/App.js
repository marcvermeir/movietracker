import { Switch, Route } from 'react-router-dom';
import Layout from './Layout';

import './App.css';
// import default style
// import 'rsuite/lib/styles/index.less'; // or 'rsuite/dist/styles/rsuite-default.css'
import 'rsuite/dist/styles/rsuite-default.css';

import WatchList from './WatchList';

function App() {
  return (
    <div className="App">
      <Layout>
        <Switch>
          <Route exact path='/' component={WatchList} />
          <Route exact path='/home' component={WatchList} />
        </Switch>
      </Layout>
    </div>
  );
}

export default App;
