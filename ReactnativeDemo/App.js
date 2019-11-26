// import React from 'react';
// import { FlatList, ActivityIndicator, Text, View  } from 'react-native';

// export default class FetchExample extends React.Component {

//   constructor(props){
//     super(props);
//     this.state ={ isLoading: true}
//   }

//   componentDidMount(){
//     return fetch('https://facebook.github.io/react-native/movies.json')
//       .then((response) => response.json())
//       .then((responseJson) => {

//         this.setState({
//           isLoading: false,
//           dataSource: responseJson.movies,
//         }, function(){

//         });

//       })
//       .catch((error) =>{
//         console.error(error);
//       });
//   }



//   render(){

//     if(this.state.isLoading){
//       return(
//         <View style={{flex: 1, padding: 20}}>
//           <ActivityIndicator/>
//         </View>
//       )
//     }

//     return(
//       <View style={{flex: 1, padding:50}}>
//         <Text>This is a demo JSON Response from https://facebook.github.io/react-native/movies.json</Text>
        
//         <FlatList
//           data={this.state.dataSource}
//           renderItem={({item}) => <Text>{item.title}, {item.releaseYear}</Text>}
//           keyExtractor={({id}, index) => id}
//         />
//       </View>
//     );
//   }
// }

import React,{Component} from 'react';
import {Text,View,StyleSheet,TouchableOpacity} from 'react-native';
class Home extends Component
{
  state={con:''}

show=()=>
{
    var req=new XMLHttpRequest();
    req.onreadystatechange=(e)=>
    {
        if(req.status==200 && req.readyState==4)
        {
            alert(req.responseText);
        }
    }
    req.open("GET","https://facebook.github.io/react-native/movies.json");
    req.send();
}

render()
{
    return(
    <View style={styles.container}>
    <TouchableOpacity onPress={()=>this.show()} style={styles.box}><Text>Click</Text></TouchableOpacity>
    <Text>{this.state.con}</Text>
    </View>
    );
}
}  
  export default Home;

const styles=StyleSheet.create({
box:
{
    padding:50,
    width:200,
    marginTop:50,
    backgroundColor:'rgba(215, 44, 149, 0.7)',
    alignItems:'center'
},
container:
{
    flexDirection:'row',
    justifyContent:'center'
}
});