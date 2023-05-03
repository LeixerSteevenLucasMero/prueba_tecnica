import { BrowserRouter as Router, Route, Switch } from 'react-router-dom';
import Navbar from './components/Navbar';
import Usuario from './components/Usuario';
import API from './components/API';

function App() {
  return (
    <Router>
      <Navbar />
      <Switch>
        <Route exact path="/" component={Usuario} />
        <Route path="/api" component={API} />
      </Switch>
    </Router>
  );
}

export default App;
