import React, { Component } from 'react';
import {  getContactById } from '../services/DataService';
import { Carousel } from 'antd';


class DetailRdv extends Component {
    constructor(props) {
        super(props);
        this.state = {
            contact: undefined,
            
        }
    }

    componentDidMount() {
        getContactById(this.props.match.params.id).then(res => {
            if(!res.data.error) {
                this.setState({
                    contact : res.data.contact
                })
            }
            else {
                alert(res.data.message)
            }
        })
    }
    
 
    render() {
        return (
            <div className="container">
                {this.state.contact != undefined ?
                    (
                        <div className="container">
                            <Carousel autoplay>
                                    {this.state.contact.images.map((image, index) =>
                                        (<div key={index}><img style={contentStyle} src={image} /></div>)
                                    )}
                                </Carousel>
                                
                            <div className="row m-1">
                                <h1 className="col">{this.state.contact.Nom}</h1>
                                <span className="col-1 h2">{this.state.contact.prenom} </span>
                            </div>
                            <div className="row m-1">
                                <h1 className="col">{this.state.contact.adresse}</h1>
                               
                            </div>
                            <div className="row m-1">
                                <h1 className="col">{this.state.contact.télephone}</h1>
                               
                            </div>
                            <div className="row m-1">
                                <h1 className="col">{this.state.contact.email}</h1>
                               
                            </div>
                         </div>
                            ) :
                            (
                                 <div>Contact Non trouvé</div>
                            )

                        
                }       
                            
            </div>
         );
    }
}

export default DetailRdv;