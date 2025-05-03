// arquivos de estilo

import MyComponent from "./MyComponent";

const FirstComponent = () => {
    // essa função faz isso


    return  (
        /* Algum comentário */
        <div>
            <h1>Meu primeiro componente.</h1>
            <p className="teste">Meu texto</p>
            <MyComponent />
        </div>
    )

}

export default FirstComponent;