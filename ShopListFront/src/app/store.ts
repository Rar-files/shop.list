import {createStore, applyMiddleware} from 'redux';
import {thunk} from 'react-thunk';

import reducers from '../reducers';

const store = createStore(reducers, applyMiddleware(thunk));

export default store;