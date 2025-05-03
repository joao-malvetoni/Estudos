const Challenge = () => {
    const handleSoma = (n1, n2) => {
        console.log(n1 + n2);
    }


    let numero1 = 2;
    let numero2 = 3;
    return (
        <div>
            <p>{numero1}</p>
            <p>{numero2}</p>
            <button onClick={(e) => {handleSoma(numero1, numero2)}}>Somar!</button>
        </div>
    )
}

export default Challenge;