import { BrowserRouter as Router, Route, Switch } from 'react-router-dom';
import Navbar from './Navbar';
import Usuarios from './Usuarios';
import API from './API';

function App() {
  return (
    <Router>
      <Navbar />
      <Switch>
        <Route path="/usuarios" component={Usuarios} />
        <Route path="/api" component={API} />
      </Switch>
    </Router>
  );
}

export default App;
