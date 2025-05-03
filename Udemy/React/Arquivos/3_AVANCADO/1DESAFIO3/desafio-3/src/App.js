import logo from './logo.svg';
import './App.css';

import Img2 from "./assets/img2.webp"
import ManageData from './components/ManageData';
import ListRender from './components/ListRender';

function App() {
  return (
    <div className="App">
      <h1>Avançando em React</h1>
      {/* Imagem em public */}
      <div>
        <img src="/img1.jpg" alt="Imagem 1" />
      </div>
      {/* Imagem em assets */}
      <div>
        <img src={Img2} alt="Imagem 2" />
      </div>
      <ManageData />
      <ListRender />
    </div>
  );
}

export default App;
