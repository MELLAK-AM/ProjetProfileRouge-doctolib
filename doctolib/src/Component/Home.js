import React from 'react';

class Home extends Component {
    constructor(props) {
        super(props);
        this.state = {  }
    }
    





    render() { 
        return ( 
            <div className="container">
                <Search onchange={(e)=>{this.search(e.target.value)}} placeholder="Votre recherche" size="large" /> 
            </div>
         );
    }
}
 
export default Home;