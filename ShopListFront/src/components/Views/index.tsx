import {FC} from 'react';
import { Routes as Switch, Route } from 'react-router-dom';

import Home from './Home';

const Views : FC = () => {
    return(
        <>
            <Switch>
                <Route path="/" element={<Home/>}/>
            </Switch>
        </>
    )
}

export default Views;